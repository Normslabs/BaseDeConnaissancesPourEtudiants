using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeConnaissancesEtudiants.DataAccess.Interfaces;
internal interface ISoftDeletes {
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }

    public void UnDelete() {
        this.IsDeleted = false; 
        this.DeletedAt = null;
    }
}
