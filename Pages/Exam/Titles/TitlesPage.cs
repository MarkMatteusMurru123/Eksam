using System.Collections.Generic;
using Aids;
using Data.Exam.Titles;
using Domain.Exam.Titles;
using Facade.Exam.Titles;

namespace Pages.Exam.Titles
{
    public abstract class TitlesPage : CommonPage<ITitlesRepository, Title, TitleView, TitleData>
    {
        public IList<StudentView> Students { get; }
        //public IEnumerable<SelectListItem> TimetableEntries { get; }

        protected internal readonly IStudentsRepository students;

        protected internal TitlesPage(ITitlesRepository TitlesRepository, IStudentsRepository studentsRepository) :
            base(TitlesRepository)
        {
            PageTitle = "Koolid";
            Students = new List<StudentView>();
            students = studentsRepository;
        }

        public override string ItemId => Item?.Id ?? string.Empty;

        protected internal override string GetPageUrl() => "/TitleSystem/Titles";

        protected internal override Title ToObject(TitleView view)
        {
            return TitleViewFactory.Create(view);
        }

        protected internal override TitleView ToView(Title obj)
        {
            return TitleViewFactory.Create(obj);
        }

        public string GetStudentName(string studentId)
        {
            foreach (var m in Students)
            {
                if (m.Id == studentId)
                    return m.Name;
            }

            return "Määramata";
        }

        public void LoadDetails(TitleView item)
        {
            Students.Clear();

            if (item is null) return;
            students.FixedFilter = GetMember.Name<StudentData>(x => x.TitleId);
            students.FixedValue = item.Id;
            var list = students.Get().GetAwaiter().GetResult();

            foreach (var e in list)
            {
                Students.Add(StudentViewFactory.Create(e));
            }
        }
    }
}
