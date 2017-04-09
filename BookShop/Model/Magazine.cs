using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    /// <summary>
    /// Representation instance of Magazine
    /// </summary>
    public class Magazine: Publication
    {
        /// <summary>
        /// Gets or sets magazine id
        /// </summary>
        public int MagazineId { get; set; }

        /// <summary>
        /// Gets or sets categories of magazine
        /// </summary>
        public string Categories { get; set; }

        /// <summary>
        /// Gets or sets frequency of magazine
        /// </summary>
        public int Frequency { get; set; }

        /// <summary>
        /// Gets or sets company of magazine
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Gets or sets number of magazine
        /// </summary>
        public int Number { get; set; }

        public Magazine()
        {

        }
    }
}
