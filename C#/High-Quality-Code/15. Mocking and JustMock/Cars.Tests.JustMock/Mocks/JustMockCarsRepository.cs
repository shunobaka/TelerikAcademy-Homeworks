namespace Cars.Tests.JustMock.Mocks
{
    using System.Linq;

    using Cars.Contracts;
    using Cars.Models;

    using Telerik.JustMock;

    public class JustMockCarsRepository : CarRepositoryMock, ICarsRepositoryMock
    {
        protected override void ArrangeCarsRepositoryMock()
        {
            this.CarsData = Mock.Create<ICarsRepository>();
            Mock.Arrange(() => this.CarsData.Add(Arg.IsAny<Car>())).DoNothing();

            Mock.Arrange(() => this.CarsData.All()).Returns(this.FakeCarCollection);

            Mock.Arrange(() => this.CarsData.Search(Arg.AnyString))
                .Returns((string search) =>
                    this.FakeCarCollection
                        .Where(c => c.Make == search || c.Model == search)
                        .ToList());
            Mock.Arrange(() => this.CarsData.Search(Arg.NullOrEmpty)).Returns(() => this.FakeCarCollection.ToList());

            Mock.Arrange(() => this.CarsData.GetById(Arg.AnyInt)).Returns((int id) => this.FakeCarCollection.FirstOrDefault(car => car.Id == id));

            Mock.Arrange(() => this.CarsData.SortedByMake()).Returns(() => this.FakeCarCollection.OrderBy(car => car.Make).ToList());
            Mock.Arrange(() => this.CarsData.SortedByYear()).Returns(() => this.FakeCarCollection.OrderBy(car => car.Year).ToList());
        }
    }
}
