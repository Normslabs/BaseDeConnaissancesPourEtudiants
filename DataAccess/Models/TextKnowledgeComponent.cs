using BaseDeConnaissancesEtudiants.DataAccess.Abstracts;
using BaseDeConnaissancesEtudiants.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeConnaissancesEtudiants.DataAccess.Models;

internal enum TextFormatEnum {
    HTML,
    Markdown,
    Code,
    RawText
}

internal class TextKnowledgeComponent : AbstractKnowledgeComponent<string>, ISoftDeletes {

    public int Id { get; set; }
    public string DisplayName { get; set; }
    public TextFormatEnum FormatType { get; set; }
    public string TextContent { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }


    public TextKnowledgeComponent(int id, string displayName, TextFormatEnum formatType, string textContent, bool isDeleted, DateTime? createdAt, DateTime? updatedAt, DateTime? deletedAt) {
        this.Id = id;
        this.DisplayName = displayName;
        this.FormatType = formatType;
        this.TextContent = textContent;
        this.IsDeleted = isDeleted;
        this.CreatedAt = createdAt;
        this.UpdatedAt = updatedAt;
        this.DeletedAt = deletedAt;
    }


    public override string GetDisplayName() {
        return this.DisplayName;
    }

    public override string GetContent() {
        return this.TextContent;
    }

    public override string ToString() {
        return this.GetDisplayName();
    }
}
