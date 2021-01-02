﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Usuarios
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "Login é Obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Senha é Obrigatório")]
        public string Senha { get; set; }
    }
}