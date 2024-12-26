namespace DomainDrivenDesign.Domain.Shared {
    public abstract class Entity : IEquatable<Entity> {
        public Guid Id { get; set; }

        public Entity(Guid id) {
            Id = id;
        }


        //referansları değil de direkt olarak idleri karşılaştırabilmem için equals metodunu override etmem lazım
        public override bool Equals(object? obj) {
            if (obj is null) return false;
            if (obj is not Entity entity) return false;
            if (obj.GetType() != GetType()) return false;
            return entity.Id == Id;
        }

        //Listelerdeki tekilliği sağlar
        public override int GetHashCode() { return Id.GetHashCode(); }

        public bool Equals(Entity? other) {
            if (other is null) return false;
            if (other is not Entity entity) return false;
            if (other.GetType() != GetType()) return false;
            return entity.Id == Id;
        }
    }
}
