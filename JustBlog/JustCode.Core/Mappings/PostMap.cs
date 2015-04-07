namespace JustCode.Core.Mappings
{
    using FluentNHibernate.Mapping;
    using Objects;

    public class PostMap : ClassMap<Post>
    {
        public PostMap()
        {
            // The Id extension method is used to represent the property name that has to be set as the primary key column of the table.
            Id(x => x.Id);

            Map(x => x.Title)
                .Length(500)
                .Not.Nullable();

            Map(x => x.Description)
                .Length(5000)
                .Not.Nullable();

            Map(x => x.Meta)
                .Length(1000)
                .Not.Nullable();

            Map(x => x.UrlSlug)
                .Length(200)
                .Not.Nullable();

            Map(x => x.Published)
                .Not.Nullable();

            Map(x => x.PostedOn)
                .Not.Nullable();

            Map(x => x.Modified);

            // The References method is used to represent the many-to-one relationship between Post and Category through a foreign key column Category in the Post table. 
            References(x => x.Category)
                .Column("Category")
                .Not.Nullable();

            // HasManyToMany method is used to represent many-to-many relationship between Post and Tag and this is achieved through an intermediate table called PostTagMap.
            HasManyToMany(x => x.Tags)
                .Table("PostTagMap");
        }
    }
}
