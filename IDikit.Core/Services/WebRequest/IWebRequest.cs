using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDikit.Core.Services
{
    public interface IWebRequest
    {
        string GetTitle(string url);
    }
}
