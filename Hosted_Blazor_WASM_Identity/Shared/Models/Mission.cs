using System.ComponentModel.DataAnnotations.Schema;

namespace Hosted_Blazor_WASM_Identity.Shared.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public string Note { get; set; }
        [ForeignKey("Entreprise")]
        public int EntrepriseID { get; set; }
        public Entreprise Entreprise { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
