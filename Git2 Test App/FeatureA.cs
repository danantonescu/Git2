using System;
using System.Collections.Generic;
using System.Text;

namespace Git2_Test_App
{
    class FeatureA
    {
        private readonly string _version;
        public string Version { get => _version; }

        public FeatureA()
        {
            _version = "a.08";
        }
    }
}
