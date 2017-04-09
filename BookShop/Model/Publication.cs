using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookShop
{
    /// <summary>
    /// Representation instance of Publication
    /// </summary>
    public class Publication
    {
        /// <summary>
        /// Gets or sets title of publication
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets number of pages
        /// </summary>
        public int Pages { get; set; }

        /// <summary>
        /// Gets or sets author of publication
        /// </summary>
        public DateTime? PublicationDate { get; set; }

        public Publication()
        {

        }
    }
}
