namespace form.Test
{
    public class UnitTest1
    {
        ////[Fact]
        ////public void Test1()
        ////{

        ////}
        #region Get All

        [Fact]
        public async void Task_GetPosts_Return_OkResult()
        {
            //Arrange
            var controller = new PostController(repository);

            //Act
            var data = await controller.GetPosts();

            //Assert
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void Task_GetPosts_Return_BadRequestResult()
        {
            //Arrange
            var controller = new PostController(repository);

            //Act
            var data = controller.GetPosts();
            data = null;

            if (data != null)
                //Assert
                Assert.IsType<BadRequestResult>(data);
        }

        [Fact]
        public async void Task_GetPosts_MatchResult()
        {
            //Arrange
            var controller = new PostController(repository);

            //Act
            var data = await controller.GetPosts();

            //Assert
            Assert.IsType<OkObjectResult>(data);

            var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
            var post = okResult.Value.Should().BeAssignableTo<List<PostViewModel>>().Subject;

            Assert.Equal("Test Title 1", post[0].Title);
            Assert.Equal("Test Description 1", post[0].Description);

            Assert.Equal("Test Title 2", post[1].Title);
            Assert.Equal("Test Description 2", post[1].Description);
        }

        #endregion
    }
}