import Author from '../models/Author';
import Genre from '../models/Genre';
import PublishingCompany from '../models/PublishingCompany';

export interface AppContextType {
  state: AppState;
  isAllfetched: boolean;
}

export interface AppState {
  authors: Author[];
  genres: Genre[];
  publishingCompanies: PublishingCompany[];
}
