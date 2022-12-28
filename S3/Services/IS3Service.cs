using S3.Models;
using S3.Models.DTO;
using System.Threading.Tasks;

namespace S3.Services
{
    public interface IS3Service
    {
        // S3DTO UploadFiletoS3BucketAsync(S3Document s3Document);
        Task<S3DTO> UploadFiletoS3BucketAsync(S3Document s3Document);
    }
}
