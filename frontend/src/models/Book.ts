import Genre from './Genre';
import PublishingCompany from './PublishingCompany';
import Author from './Author';

export default interface Book {
  id: number;
  title: string;
  publishDate: string;
  pages: number;
  description: string;
  synopsis: string;
  imageUrl: string;
  buyLink?: string;
  authorId: number;
  author: Author | null;
  publishingCompanyId: number;
  publishingCompany: PublishingCompany | null;
  genreId: number;
  genre: Genre | null;
}
