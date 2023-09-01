using BaseDeConnaissancesEtudiants.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeConnaissancesEtudiants.DataAccess.Abstracts;

/// <summary>
/// Classe abstraite pour les composantes des connaissances préalables.
/// </summary>
/// <typeparam name="TContentType">Le type de contenur de la composante</typeparam>
internal abstract class AbstractKnowledgeComponent<TContentType> : IKnowledgeComponent<TContentType> {

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns><inheritdoc/></returns>
    public abstract TContentType GetContent();
    public abstract string GetDisplayName();

    public override string ToString() {
        return this.GetDisplayName();
    }
}
