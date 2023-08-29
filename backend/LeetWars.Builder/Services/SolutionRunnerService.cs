using Docker.DotNet;
using Docker.DotNet.Models;
using LeetWars.Builder.Interfaces;

namespace LeetWars.Builder.Services
{
    public class SolutionRunnerService : ISolutionRunnerService, IDisposable
    {
        private readonly DockerClient _client = new DockerClientConfiguration().CreateClient();

        public async Task RunCodeInContainerAsync(string imageName, string containerName)
        {
            var containerParams = new CreateContainerParameters
            {
                Image = imageName,
                Name = containerName
            };

            var container = await _client.Containers.CreateContainerAsync(containerParams);

            await _client.Containers.StartContainerAsync(container.ID, null);

            await _client.Containers.WaitContainerAsync(container.ID);

            await _client.Containers.RemoveContainerAsync(container.ID, new ContainerRemoveParameters());
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            _client?.Dispose();
        }
    }
}
