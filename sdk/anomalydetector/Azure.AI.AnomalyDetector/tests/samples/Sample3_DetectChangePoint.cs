﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Azure.AI.AnomalyDetector.Models;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.AnomalyDetector.Tests.Samples
{
    public partial class AnomalyDetectorSamples : RecordedTestBase<AnomalyDetectorTestEnvironment>
    {
        [Test]
        public async Task DetectChangePoint()
        {
            //read endpoint and apiKey
            string endpoint = TestEnvironment.Endpoint;
            string apiKey = TestEnvironment.ApiKey;

            var endpointUri = new Uri(endpoint);
            var credential = new AzureKeyCredential(apiKey);

            //create client
            AnomalyDetectorClient client = new AnomalyDetectorClient(endpointUri, credential);

            //read data
            string datapath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "samples", "data", "request-data.csv");

            List<Point> list = File.ReadAllLines(datapath, Encoding.UTF8)
                .Where(e => e.Trim().Length != 0)
                .Select(e => e.Split(','))
                .Where(e => e.Length == 2)
                .Select(e => new Point(DateTime.Parse(e[0]), float.Parse(e[1]))).ToList();

            //create request
            ChangePointDetectRequest request = new ChangePointDetectRequest(list, Granularity.Daily);

            //detect
            Console.WriteLine("Detecting the change point in the series.");
            try
            {
                ChangePointDetectResponse result = await client.ChangePointDetectAsync(request).ConfigureAwait(false);

                if (result.IsChangePoint.Contains(true))
                {
                    Console.WriteLine("A change point was detected at index:");
                    for (int i = 0; i < request.Series.Count; ++i)
                    {
                        if (result.IsChangePoint[i])
                        {
                            Console.Write(i);
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No change point detected in the series.");
                }
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine("Error code: " + ex.ErrorCode);
                Console.WriteLine("Error message: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
