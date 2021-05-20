using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Models
{
    public class FixCarAmaduesReponse
    {
        public int SomeNumber { get; set; }
        public int CarId { get; set; }
    }

    public class FixCarAmaduesRequest
    {
        public string Car { get; set; }
        public int Color { get; set; }
    }

    public class GetCarAmaduesResponse
    {
        public int SomeNumber1 { get; set; }
    }

    public class GetCarAmaduesRequest
    {
        public string Car1 { get; set; }
        
    }
}
