using BaseDeConnaissancesEtudiants.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeConnaissancesEtudiants.DataAccess.Interceptors;
internal class SoftDeleteInterceptor : SaveChangesInterceptor {
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result) {
        if (eventData.Context is null) {
            return result;
        }

        foreach (EntityEntry entry in eventData.Context.ChangeTracker.Entries()) {
            if (entry is not { State: EntityState.Deleted, Entity: ISoftDeletes entity }) {
                continue;
            }
            entry.State = EntityState.Modified;
            entity.IsDeleted = true;
            entity.DeletedAt = DateTime.Now;
        }

        return result;
    }
}
