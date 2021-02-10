using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Web;

namespace WebApp.Models
{
    public class NicknameAndEmailViewModel
    {

        [Required(ErrorMessageResourceName = "NicknameRequiredErrorMsg", ErrorMessageResourceType = typeof(I18n.Resource))]
        [Display(Name = "NicknameLabel", ResourceType = typeof(I18n.Resource))]
        public string Nickname { get; set; }

        [Required]
        [Display(Name = "EmailLabel", ResourceType = typeof(I18n.Resource))]
        [DataType(DataType.EmailAddress,ErrorMessageResourceName = "EmailInvalidErrorMsg", ErrorMessageResourceType = typeof(I18n.Resource))]
        public string Email { get; set; }



    }
}