﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Azure.AI.FormRecognizer.Models;

namespace Azure.AI.FormRecognizer
{
    public class ExtractedForm
    {
        internal ExtractedForm(ICollection<PageResult_internal> pageResults)
        {
            // Unsupervised
            Pages = SetPages(pageResults);

            // TODO: how to set PageRange?
        }

        internal ExtractedForm(DocumentResult documentResult)
        {
            // Supervised
            LearnedFormId = documentResult.DocType;
            PageRange = new PageRange(documentResult.PageRange);
            Pages = SetPages(documentResult);
        }

        public string LearnedFormId { get; internal set; }

        public PageRange PageRange { get; internal set; }

        public IReadOnlyList<ExtractedPage> Pages { get; }

        private IReadOnlyList<ExtractedPage> SetPages(ICollection<PageResult_internal> pageResults)
        {
            List<ExtractedPage> pages = new List<ExtractedPage>();
            foreach (var result in pageResults)
            {
                SetLearnedFormId(result.ClusterId);

                ExtractedPage page = new ExtractedPage(result);
                pages.Add(page);
            }

            return pages.AsReadOnly();
        }

        private static IReadOnlyList<ExtractedPage> SetPages(DocumentResult documentResult)
        {
            List<ExtractedPage> pages = new List<ExtractedPage>();

            // TODO: improve performance here
            Dictionary<int, List<ExtractedField>> fieldsByPage = new Dictionary<int, List<ExtractedField>>();
            foreach (var field in documentResult.Fields)
            {
                // TODO: page 0 if null, can we do better?
                // TODO: How should we handle the multiple values per field and the strongly-typed ones?
                List<ExtractedField> list;
                if (!fieldsByPage.TryGetValue(field.Value.Page ?? 0, out list))
                {
                    fieldsByPage[field.Value.Page ?? 0] = new List<ExtractedField>();
                }
                fieldsByPage[field.Value.Page ?? 0].Add(
                        new ExtractedField()
                        {
                            Confidence = field.Value.Confidence,
                            Label = field.Key,
                            Value = field.Value.Text,
                            ValueOutline = new BoundingBox(field.Value.BoundingBox)
                        });
            }

            foreach (var pageFields in fieldsByPage)
            {
                var page = new ExtractedPage(pageFields.Key, pageFields.Value);
                pages.Add(page);
            }

            return pages.AsReadOnly();
        }

        private void SetLearnedFormId(int? clusterId)
        {
            // TODO: Provide IFormatProvider
#pragma warning disable CA1305 // Specify IFormatProvider
            string formId = clusterId?.ToString();
#pragma warning restore CA1305 // Specify IFormatProvider

            // TODO: Does this make sense?
            if (formId != null)
            {
                Debug.Assert(LearnedFormId == formId, "Multiple form types found in ExtractedForm.");
                LearnedFormId = formId;
            }
        }
    }
}
