//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            this.ArticleToCategory = new HashSet<ArticleToCategory>();
            this.Comment = new HashSet<Comment>();
        }
    
        public System.Guid ArticleId { get; set; }
        public System.DateTime ArticleCreateDateTime { get; set; }
        public int ArticleIsRemoved { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public System.Guid ArticleUserId { get; set; }
        public int ArticleLikeCount { get; set; }
        public int ArticleUnlikeCount { get; set; }
    
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticleToCategory> ArticleToCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comment { get; set; }
    }
}
