using Microsoft.AspNetCore.Http;

using System.Net;

namespace WebFileMangement.StorageBroker.Services;

public interface IStorageBrokerService
{
    Task CreateFolderAsync(string folderpath);
    Task UpdateFileWithChunks(IFormFile file, string? folderPath);
    Task GetContentOfTxtFile();
    Task 
    Task CreateDirectoryAsync(string directoryPath);
    Task<List<string>> GetAllFilesAndDirectoriesAsync(string directoryPath);
    Task<Stream> DownloadFileAsync(string filePath);
    Task<Stream> DownloadFolderAsZipAsync(string directoryPath);
    Task DeleteFileAsync(string filePath);
    Task DeleteDirectoryAsync(string directoryPath);
    Task UpdateFileWithChunks();
} 
