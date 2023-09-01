using BaseDeConnaissancesEtudiants.DataAccess.Interfaces;
using NSAIL.ApplicationComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeConnaissancesEtudiants.Business.Interfaces;

/// <summary>
/// Interface commune pour tous les services fournisseurs de composantes de connaissances.
/// </summary>
public interface IKnowledgeComponentProvider : IService {
    const string DISCRIMINANT = "KNOWLEDGE_COMPONENT_PROVIDER";

    protected List<IKnowledgeComponent> KnowledgeComponents { get; }

    /// <summary>
    /// Retourne une <see cref="List{IKnowledgeComponent}"/> contenant les composantes de connaissances fournies par le service.
    /// </summary>
    /// <returns>La liste d'éléments de connaissances préalables fournies par le service</returns>
    List<IKnowledgeComponent> GetKnowledgeComponentsList();

    /// <summary>
    /// Ajoute les composantes de connaissances fournies par le service à la <paramref name="list"/> fournie.
    /// </summary>
    /// <param name="list">La liste à laquelle ajouter les composantes.</param>
    void AddKnowledgeComponentsToList(List<IKnowledgeComponent> list);

}