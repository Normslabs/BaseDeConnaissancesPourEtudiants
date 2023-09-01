﻿using BaseDeConnaissancesEtudiants.Business.Interfaces;
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
        html, body {
            font-family: Arial, sans-serif;
            height: 100%;
            width: 99%;
        }

        .full-width {
            width: 100%;
        }

        .text-center {
            text-align: center;
        }

        .container {
            width: 100%;
        }

        .title,
        .paragraph {
            font-family: Arial, sans-serif;
            margin-right: 20px;
        }

        .code {
            font-family: 'Source Code Pro'
        }

        .technincal-term {
            font-weight: bold;
            font-style: italic;
            color: blue;
        }
        .quote {
            font-style: italic;
            padding: 0 20px 0 20px;
        }
    </style>
</head>
<body>
    <div class=""container"">
        <h2 class=""full-width text-center title"">EXPRESSIONS ET INSTRUCTIONS</h2>
        <p class=""quote"">
            In computer science, an expression is a syntactic entity in a programming language that may be evaluated 
            to determine its value.[1] It is a combination of one or more constants, variables, functions, and operators 
            that the programming language interprets (according to its particular rules of precedence and of association) 
            and computes to produce (""to return"", in a stateful environment) another value. This process, for mathematical 
            expressions, is called evaluation. In simple settings, the resulting value is usually one of various primitive 
            types, such as string, boolean, or numerical (such as integer, floating-point, or complex).
            Expressions are often contrasted with statements—syntactic entities that have no value (an instruction).<br/>
            <bold>- Wikipedia</bold>
        </p>
        <p class=""paragraph"">
            Une <span class=""technincal-term"">instruction</span> est une opération ou une suite d'opérations qui
            réalisent quelque chose. En C#, Java PHP et plusieurs autres langages, les instructions sont
            séparées par des points-virgules. Une instruction peut être, mais n'est pas forcément, 
            <span class=""technincal-term"">évaluable</span>. Par exemple, les éléments suivants sont des instructions:
        </p>
        <p class=""paragraph"">
            <ul class=""code"">
                <li>int maVariable;		// déclaration d'une variable</li>
                <li>maVariable = 5;		// assignation d'une valeur à une variable</li>
                <li>objet.Methode();	// appel de fonction/méthode</li>
            </ul>
        </p>
        <p class=""paragraph"">
            Contrairement aux instructions, les <span class=""technincal-term"">expression</span> <bold>DOIVENT</bold>
            être <span class=""technincal-term"">évaluables</span>. C'est-à-dire qu'on doit pouvoir calculer
            la valeur de l'entièreté de l'expression. On peut donc dire, même si ce n'est pas techniquement exact, qu'une
            expression 'retourne' une valeur unique lorsque exécutée dans un programme.
        </p>
        <p>
            Les expressions sont composées d'une combinaison d'une ou plusieurs <span class=""technincal-term"">valeurs litérales</span>,
            <span class=""technincal-term"">variables</span>, <span class=""technincal-term"">constantes</span>,
            appels de <span class=""technincal-term"">fonction/méthode</span> et <span class=""technincal-term"">opérateurs</span>.
            Par exemple, les éléments suivants sont tous des expressions:
        </p>
        <p class=""paragraph"">
            <ul class=""code"">
                <li>2</li>
                <li>""unString""</li>
                <li>uneVariable</li>
                <li>objet.Methode()</li>
                <li>(34 + maVariable) * objet.Methode()</li>
            </ul>
        </p>
        <p class=""paragraph"">
            Chacun de ces exemples 'retourne' une valeur lorsqu'exécuté dans un programme: les variables sont évaluées
            à leur valeur à ce moment là, les appels de fonction sont exécutés et retournent une valeur, et l'ensemble
            des opérations sur ces éléments est aussi calculée.
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
