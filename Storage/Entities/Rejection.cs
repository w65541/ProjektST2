using System;
using System.Collections.Generic;

#nullable disable

namespace Storage
{
    public partial class Rejection
    {
        public int Id { get; set; }
        public int Rejectee { get; set; }
        public int Rejected { get; set; }

        public virtual Profil RejectedNavigation { get; set; }
        public virtual Profil RejecteeNavigation { get; set; }
    }
}
