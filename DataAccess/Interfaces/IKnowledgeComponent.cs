using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeConnaissancesEtudiants.DataAccess.Interfaces;

/// <summary>
/// Interface commune pour tous les types de composantes des connaissances préalables.
/// </summary>
public interface IKnowledgeComponent {

    /// <summary>
    /// Retourne un <see cref="string"/> représentant le nom pour affichage de la composante des connaissances préalables.
    /// </summary>
    /// <returns>Le nom de la composante des connaissances préalables</returns>
    string GetDisplayName();
    string ToString();

}

/// <summary>
/// Interface générique commune à tous les types de composantes des connaissances préalables.
/// </summary>
/// <typeparam name="TContentType">Le type du contenu à afficher</typeparam>
public interface IKnowledgeComponent<TContentType> : IKnowledgeComponent {

    /// <summary>
    /// Retourne le contenu à afficher pour cette composante des connaissances préalables.
    /// </summary>
    /// <returns>Le contenu à afficher</returns>
    TContentType GetContent();

}
