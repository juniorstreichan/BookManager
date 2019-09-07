import Genre from '../models/Genre';
import Author from '../models/Author';
import PublishingCompany from '../models/PublishingCompany';

export function selectGenre(id: number, state: Genre[]): Genre {
  return state.filter(g => g.id === id)[0];
}

export function selectAuthor(id: number, state: Author[]): Author {
  return state.filter(g => g.id === id)[0];
}

export function selectPublishingCompany(id: number, state: PublishingCompany[]): PublishingCompany {
  return state.filter(g => g.id === id)[0];
}
