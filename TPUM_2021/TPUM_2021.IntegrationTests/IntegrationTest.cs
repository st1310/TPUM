using Moq;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using TPUM_2021.ClientData;
using AppContext = TPUM_2021.ClientData.AppContext;

namespace TPUM_2021.IntegrationTests
{
    [TestFixture]
    public class IntegrationTest
    {
        [Test]
        public async Task ConnectToServerTest()
        {
            // Arrange
            AppContext context = new AppContext(8081, false);

            var promise = new TaskCompletionSource<string>();
            RepositoryObserver observer = new RepositoryObserver();
            observer.onMessage = data => promise.TrySetResult(data);
            observer.Subscribe(context);

            // Act
            Process process = Process.Start("..\\..\\..\\..\\TPUM_2021.ServerPresentation\\bin\\Debug\\netcoreapp3.1\\TPUM_2021.ServerPresentation.exe");
            Task.Factory.StartNew(() => context.ConnectClient());

            string result = await promise.Task;

            process.Kill();

            // Assert
            Assert.IsTrue(result.Equals("Connected"));
        }
    }
}