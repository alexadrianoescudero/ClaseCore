﻿using System;
using System.Collections.Generic;

namespace Externo.ModelosNuevos
{
    public partial class AspNetRoleClaims
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string RoleId { get; set; }

        public AspNetRoles Role { get; set; }
    }
}
