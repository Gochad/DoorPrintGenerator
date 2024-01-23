using DoorPrintGenerator.Components.Pages;

namespace DoorPrintGenerator.test;

using Xunit;

// Assuming your Blazor app's namespace is BlazorSchool.Components.Web.UI
using BlazorSchool.Components.Web.UI;

    public class HomeTests
    {
       [Fact]
        public void TestInitialEditModeIsFalse()
        {
            // Arrange
            var homePage = new Home();

            // Assert
            Assert.False(homePage.EditMode);
        }

        [Fact]
        public void TestShowRoomNumberModal()
        {
            // Arrange
            var homePage = new Home();

            // Act
            homePage.OnShowRoomNumberClick();

            // Assert
            Assert.True(homePage.RoomNumber.IsVisible);
        }

        [Fact]
        public void TestEditButtonChangesEditMode()
        {
            // Arrange
            var homePage = new Home();

            // Act
            homePage.OnEditButtonClick();

            // Assert
            Assert.True(homePage.EditMode);
        }

        [Fact]
        public void TestSaveAsJsonSavesCorrectly()
        {
            // Arrange
            var homePage = new Home();
            homePage.RoomNumber.Value = "123";
            homePage.Names.Value = "John Doe";

            // Act
            homePage.SaveAsJson();

            // Assert
            // Dodaj odpowiednie asercje na podstawie Twojej implementacji
        }

        [Fact]
        public void TestLoadFilesUpdatesData()
        {
            // Arrange
            var homePage = new Home();
            var fileInfo = new Info { RoomNumber = "456", Names = "Jane Doe" };

            // Act
            homePage.LoadFiles(new InputFileChangeEventArgs(new FileChangeEventArgs { File = new BrowserFileMock(fileInfo) }));

            // Assert
            Assert.Equal("456", homePage.RoomNumber);
            Assert.Equal("Jane Doe", homePage.Names);
        }

        // Dodatkowe testy w zależności od funkcji na Twojej stronie...
    }

    // Emulacja IBrowserFile do testów
    public class BrowserFileMock : IBrowserFile
    {
        private readonly Info fileInfo;

        public BrowserFileMock(Info fileInfo)
        {
            this.fileInfo = fileInfo;
        }

        public Stream OpenReadStream(long maxAllowedSize = 0)
        {
            var json = JsonSerializer.Serialize(fileInfo);
            return new MemoryStream(Encoding.UTF8.GetBytes(json));
        }

    }

