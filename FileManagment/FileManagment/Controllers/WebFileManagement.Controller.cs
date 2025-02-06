using Microsoft.AspNetCore.Mvc;

using WebFileManagement.Service.Services;


namespace FileManagment.Controllers

public class WebFileManagementController : IStorageService
{
	private readonly IStorageService _storageService;
	[HttpPost("CreateDirectory")]
	public async Task CreateDirectoryAsync(string directoryPath)
	{
		_storageService.DeleteFileAsync(directoryPath);
	}

	public async Task CreateFolderAsync(string folderpath)
	{
		_storageService.CreateFolderAsync(folderpath);
	}

	[HttpPost("DeleteDirectory")]
	public async Task DeleteDirectoryAsync(string directoryPath)
	{
		_storageService.DeleteDirectoryAsync(directoryPath);
	}
	[HttpDelete("DeleteFile")]
	public async Task DeleteFileAsync(string filePath)
	{
		_storageService.DeleteFileAsync(filePath);
	}
	[HttpDelete("DownloadFile")]
	public async Task<Stream> DownloadFileAsync(string filePath) => await _storageService.DownloadFileAsync(filePath);
	[HttpGet("DownloadFolderAsZip")]
	public async Task<Stream> DownloadFolderAsZipAsync(string directoryPath) => await _storageService.DownloadFolderAsZipAsync(directoryPath);
	[HttpGet("GetAllFilesAndDirectories")]
	public async Task<List<string>> GetAllFilesAndDirectoriesAsync(string directoryPath) => await _storageService.GetAllFilesAndDirectoriesAsync(directoryPath);

	public async Task GetContentOfTxtFile()
	{
		_storageService.GetContentOfTxtFile();
	}

	public async Task UpdateFileWithChunks(IFormFile file, string? folderPath)
	{
		_storageService.UpdateFileWithChunks(file, folderPath);
	}

	[HttpPost("UploadFileAsync")]
	public async Task UploadFileAsync(string filePath, Stream stream)
	{
		_storageService.DeleteFileAsync(filePath);
	}
}
