import * as Yup from 'yup';

export interface NewBookForm {
  title?: string;
  publishDate?: string;
  pages?: number;
  description?: string;
  synopsis?: string;
  imageUrl?: string;
  buyLink?: string;
  authorId?: number;
  publishingCompanyId?: number;
  genreId?: number;
}

export const defaultBook = {
  id: 0,
  title: undefined,
  publishDate: undefined,
  pages: 0,
  description: undefined,
  synopsis: undefined,
  imageUrl: undefined,
  buyLink: undefined,
  authorId: 0,
  publishingCompanyId: undefined,
  genreId: 0,
};

export const newBookSchema = Yup.object().shape({
  title: Yup.string().required('Titulo é obrigatório'),
  publishDate: Yup.string().required('Data de publicação é obrigatória'),
  pages: Yup.number()
    .min(50, 'Minimo 50 páginas')
    .required('Quantidade de páginas é obrigatório'),
  description: Yup.string().required('Descrição é obrigatória'),
  synopsis: Yup.string().required('Sinopse é obrigatória'),
  imageUrl: Yup.string()
    .url('link inválido')
    .required('Imagem é obrigatória'),
  buyLink: Yup.string()
    .url('link inválido')
    .nullable(),
  authorId: Yup.number()
    .min(1, 'Autor inválido')
    .required('Autor é obrigatório'),
  publishingCompanyId: Yup.number()
    .min(1, 'Editora inválida')
    .required('Editora é obrigatória'),
  genreId: Yup.number()
    .min(1, 'Gênero inválido')
    .required('Gênero é obrigatório'),
});

export const editBookSchema = Yup.object().shape({
  id: Yup.number().min(1, 'LIvro inválido'),
  title: Yup.string().required('Titulo é obrigatório'),
  publishDate: Yup.string().required('Data de publicação é obrigatória'),
  pages: Yup.number()
    .min(50, 'Minimo 50 páginas')
    .required('Quantidade de páginas é obrigatório'),
  description: Yup.string().required('Descrição é obrigatória'),
  synopsis: Yup.string().required('Sinopse é obrigatória'),
  imageUrl: Yup.string()
    .url('link inválido')
    .required('Imagem é obrigatória'),
  buyLink: Yup.string()
    .url('link inválido')
    .nullable(),
  authorId: Yup.number()
    .min(1, 'Autor inválido')
    .required('Autor é obrigatório'),
  publishingCompanyId: Yup.number()
    .min(1, 'Editora inválida')
    .required('Editora é obrigatória'),
  genreId: Yup.number()
    .min(1, 'Gênero inválido')
    .required('Gênero é obrigatório'),
});
