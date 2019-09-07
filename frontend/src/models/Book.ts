export default interface Book {
  id: number;
  title: string;
  publishDate: string;
  pages: number;
  description: string;
  synopsis: string;
  imageUrl: string;
  buyLink?: any;
  authorId: number;
  author?: any;
  publishingCompanyId: number;
  publishingCompany?: any;
  genreId: number;
  genre?: any;
}
