using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FederataFutbollit.DTOs
{
    public class TokenApiModel
    {
          public string AccessToken { get; set; }
            public string RefreshToken { get; set; }
    }
}