﻿namespace Baufest.NHibernate.Dominio.Entidades
{
    public class Producto
    {
        public virtual int Id { get; set; }

        public virtual string Nombre { get; set; }

        public virtual string Descripcion { get; set; }

        public virtual decimal Precio { get; set; }
    }
}
