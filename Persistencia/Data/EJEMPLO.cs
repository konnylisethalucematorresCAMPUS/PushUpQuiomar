 builder.HasOne(p => p.Nombres ) //Nombre de la tabla que esta mandando en plural
                .WithMany(p => p.Personas) //Nombre de la tabla que esta recibiendo pero en plural
                .HasForeignKey(p => p.IdCategoria); //Nombre de Id de la tabla