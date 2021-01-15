﻿using Data.Exam.Titles;
using Domain.Exam.Titles;

namespace Infra.Exam.Titles
{
    public sealed class TitlesRepository : UniqueEntityRepository<Title, TitleData>, ITitlesRepository
    {
        public TitlesRepository(ProjectDbContext c) : base(c, c.Titles) { }

        protected internal override Title ToDomainObject(TitleData d) => new Title(d);
    }
}
