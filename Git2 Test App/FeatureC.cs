using System;
using System.Collections.Generic;
using System.Text;

namespace Git2_Test_App
{
    class FeatureC
    {
        private readonly string _version;
        public string Version { get => _version; }

        public FeatureC()
        {
            _version = "c.00";
        }
    }
}
