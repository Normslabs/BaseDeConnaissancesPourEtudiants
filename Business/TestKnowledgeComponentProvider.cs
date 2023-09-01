using BaseDeConnaissancesEtudiants.Business.Interfaces;
using BaseDeConnaissancesEtudiants.DataAccess.Interfaces;
using BaseDeConnaissancesEtudiants.DataAccess.Models;
using NSAIL;
using NSAIL.ApplicationComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeConnaissancesEtudiants.Business;

/// <summary>
/// Service fournisseurs d'éléments de connaissances préalables hardodées.
/// </summary>
public class TestKnowledgeComponentProvider : AbstractService, IKnowledgeComponentProvider {


    private static readonly string TEST_HTML = @"
<!DOCTYPE html>
<html>
<head>
    <style>
    </style>
</head>
<body>
    <div class=""container"">
        <h3 class=""title"">EXPRESSIONS ET INSTRUCTIONS</h3>
        <p class=""paragraph"">
            Comme en mathématiques, une expression est une valeur litérale, une variable, un appel de fonction, ou 
            toute combinaison de ceux - ci dans une chaîne d'opérationsqui DOIT POUVOIR, pour un moment donné, être 
            ÉVALUÉ pour donner une valeur unique. On peut donc dire, même si ce n'est pas techniquement exact, qu'une
            expression 'retourne' une valeur unique lorsque exécuté dans un programme. Par exemple, les éléments 
            suivants sont tous des expressions:
        </p>
        <p class=""paragraph"">
            <ul>
                <li>2</li>
                <li>""unString""</li>
                <li>uneVariable</li>
                <li>objet.Methode()</li>
                <li>(34 + maVariable) * objet.Methode()</li>
            </ul>
        </p>
        <p class=""paragraph"">
            Chacun de ces exemples 'retourne' une valeur lorsqu'exécuté dans un programme: les variables sont évaluées 
            pour leur valeur à ce moment là, les appels de fonction sont exécutés et retournent une valeur, et l'ensemble 
            des opérations sur ces éléments est aussi calculable sur le champ.
        </p>
        <p class=""paragraph"">
            Une instruction est une commande ou une opération qui 'fait' quelque chose. En C#, les instructions sont 
            séparées par des points-virgules. Contrairement à une expression, une instruction peut, MAIS N'EST PAS 
            OBLIGÉ d'être évaluable. Par exemple, les éléments suivants sont des instructions:
        </p>
        <p class=""paragraph"">
            <ul>
                <li>int maVariable;		// déclaration d'une variable</li>
                <li>maVariable = 5;		// assignation d'une valeur à une variable</li>
                <li>objet.Methode();	// appel de méthode (l'appel lui-même est aussi une expression)</li>
            </ul>
        </p>
    </div>
</body>
</html>
";
    private static readonly string TEST_CODE = @"
/// <summary>
/// Classe abstraite pour les composantes des connaissances préalables.
/// </summary>
/// <typeparam name=""TContentType"">Le type de contenur de la composante</typeparam>
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
";
    private static readonly string TEST_MARKDOWN = @"
# THIS IS MARKDOWN TEXT

### A Subtitle

What do you know? Markdown code works!
";


    public List<IKnowledgeComponent> KnowledgeComponents { get; protected set; }

    public TestKnowledgeComponentProvider(IApplication parent) : base(IKnowledgeComponentProvider.DISCRIMINANT, parent) {
        this.KnowledgeComponents = new List<IKnowledgeComponent> {
            new TextKnowledgeComponent(1, "Test HTML", TextFormatEnum.HTML, TEST_HTML, false, null, null, null),
            new TextKnowledgeComponent(2, "Test Raw Text", TextFormatEnum.RawText, "Xum bouittle Grutelbit", false, null, null, null),
            new TextKnowledgeComponent(3, "Test Raw Code", TextFormatEnum.Code, TEST_CODE, false, null, null, null),
            new TextKnowledgeComponent(4, "Test Markdown", TextFormatEnum.Markdown, TEST_MARKDOWN, false, null, null, null)
        };
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="list"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void AddKnowledgeComponentsToList(List<IKnowledgeComponent> list) {
        list.AddRange(this.KnowledgeComponents);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <remarks>
    /// Implémentation de <see cref="IKnowledgeComponentProvider.GetKnowledgeComponentsList"/>
    /// </remarks>
    /// <returns><inheritdoc/></returns>
    public List<IKnowledgeComponent> GetKnowledgeComponentsList() {
        return this.KnowledgeComponents;
    }
}
