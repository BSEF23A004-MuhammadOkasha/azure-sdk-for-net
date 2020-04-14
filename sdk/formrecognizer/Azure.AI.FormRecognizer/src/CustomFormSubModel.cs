﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.AI.FormRecognizer.Models;

namespace Azure.AI.FormRecognizer.Training
{
    /// <summary>
    /// Represents a submodel that extracts fields from a specific type of form.  
    /// trained on, and the form type.
    /// </summary>
    public class CustomFormSubModel
    {
        internal CustomFormSubModel(string formType, float? accuracy, IReadOnlyDictionary<string, CustomFormModelField> fields)
        {
            FormType = formType;
            Accuracy = accuracy;
            Fields = fields;
        }

        /// <summary>
        ///  Type of form this submodel recognizes.
        /// </summary>
        public string FormType { get; internal set; }

        /// <summary>
        /// The mean of the model's field accuracies.
        /// </summary>
        public float? Accuracy { get; internal set; }

        /// <summary>
        /// Form fields that this submodel will extract when analyzing this form type.
        /// </summary>
        public IReadOnlyDictionary<string, CustomFormModelField> Fields { get; internal set; }

        /// <summary>
        /// Errors returned during the training operation.
        /// </summary>
        public IReadOnlyList<FormRecognizerError> Errors { get; internal set; }
    }
}
