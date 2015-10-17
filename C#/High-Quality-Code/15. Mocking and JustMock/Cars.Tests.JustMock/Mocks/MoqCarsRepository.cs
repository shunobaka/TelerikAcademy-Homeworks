namespace Cars.Tests.JustMock.Mocks
{
    using Cars.Contracts;
    using Cars.Models;
    using Moq;
    using System.Linq;

    public class MoqCarsRepository : CarRepositoryMock, ICarsRepositoryMock
    {
        protected override void ArrangeCarsRepositoryMock()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();
            mockedCarsRepository.Setup(r => r.Add(It.IsAny<Car>())).Verifiable();

            mockedCarsRepository.Setup(r => r.All()).Returns(this.FakeCarCollection);

            mockedCarsRepository.Setup(r => r.Search(It.IsNotNull<string>())).Returns((string search) => 
                this.FakeCarCollection
                    .Where(c => c.Make == search || c.Model == search).ToList());
            mockedCarsRepository.Setup(r => r.Search(It.Is<string>(s => string.IsNullOrEmpty(s)))).Returns(() => this.FakeCarCollection.ToList());

            mockedCarsRepository.Setup(r => r.GetById(It.IsAny<int>())).Returns((int id) => this.FakeCarCollection.FirstOrDefault(car => car.Id == id));

            mockedCarsRepository.Setup(r => r.SortedByMake()).Returns(() => this.FakeCarCollection.OrderBy(car => car.Make).ToList());
            mockedCarsRepository.Setup(r => r.SortedByYear()).Returns(() => this.FakeCarCollection.OrderBy(car => car.Year).ToList());
            this.CarsData = mockedCarsRepository.Object;
        }
    }
}
