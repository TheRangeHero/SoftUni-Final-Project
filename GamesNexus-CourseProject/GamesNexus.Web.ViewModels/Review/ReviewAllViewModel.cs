using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GamesNexus.Web.ViewModels.Review
{
    public class ReviewAllViewModel
    {
        public string Rating { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public string PostedOn { get; set; } = null!;
        public string PostedBy { get; set; } = null!;

    }
}
