const allowedPictureFileExtensions = ['jpg', 'JPG', 'png', 'PNG'];

export function validatePictureFileName(fileName: string): boolean {
    const fileExtension = fileName.split('.')[1];

    return allowedPictureFileExtensions.includes(fileExtension);
}
