using System;
using System.Collections.Generic;
using System.Text;

namespace Git2_Test_App
{
    class FeatureB
    {
        private readonly string _version;
        public string Version { get => _version; }

        public FeatureB()
        {
            _version = "b.00";
        }
    }
}
