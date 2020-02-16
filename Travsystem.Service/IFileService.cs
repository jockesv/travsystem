using Travsystem.Model;

namespace Travsystem.Service
{
    public interface IFileService
    {
        BetFileResponse SaveATGFile(BetFileRequest request);
    }
}