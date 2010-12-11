﻿/*
 * Original author: Brendan MacLean <brendanx .at. u.washington.edu>,
 *                  MacCoss Lab, Department of Genome Sciences, UW
 *
 * Copyright 2010 University of Washington - Seattle, WA
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System.IO;
using pwiz.Skyline.Util;

namespace pwiz.Skyline.Model.Results
{
    internal class NoSrmDataException : IOException
    {
        public NoSrmDataException()
            : base("No SRM/MRM data found")
        {
        }
    }

    internal class LoadCanceledException : IOException
    {
        public LoadCanceledException(ProgressStatus status)
            : base("Data import canceled")
        {
            Status = status;
        }

        public ProgressStatus Status { get; private set; }
    }

}