﻿namespace ProyectoWebAPI.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string? NombreCompleto { get; set; }
        public Departamento? Departamento{ get; set; }
        public decimal? Sueldo { get; set; }
        public string? FechaContrato { get; set; }
    }
}
