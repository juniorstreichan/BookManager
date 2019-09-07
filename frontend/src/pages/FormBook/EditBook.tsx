import { Form, Formik, FormikProps } from 'formik';
import React from 'react';
import { Prompt } from 'react-router';
import { Button, Grid, Icon } from 'semantic-ui-react';
import DropdownAuthors from '../../components/Dropdowns/DropdownAuthors';
import DropdownGenres from '../../components/Dropdowns/DropdownGenres';
import DropdownPublishingCompany from '../../components/Dropdowns/DropdownPublishingCompany';
import InputForm, { CustomError } from '../../components/Form/InpuForm';
import Book from '../../models/Book';
import { editBookSchema, NewBookForm } from './schemas';

interface Props {
  onSubmit: (book: Book | NewBookForm) => void;
  onCancel: Function;
  book: Book;
}

const EditBook: React.FC<Props> = ({ onSubmit, onCancel, book }) => {
  return (
    <Formik
      validationSchema={editBookSchema}
      initialValues={book}
      onSubmit={(book: NewBookForm, actions) => {
        actions.resetForm();
        onSubmit(book);
      }}
      render={(formikState: FormikProps<NewBookForm>) => {
        const { values } = formikState;
        return (
          <Form>
            <Prompt
              when={formikState.dirty}
              message="Você perderá os dados cadastrados, tem certeza que deseja sair?"
            />
            <Grid centered>
              <Grid.Row>
                <Grid.Column mobile={16} tablet={8} computer={8}>
                  <InputForm fluid name="title" size="large" label="Titulo" />
                </Grid.Column>
              </Grid.Row>
              {/*  */}
              <Grid.Row>
                <Grid.Column mobile={16} tablet={8} computer={8}>
                  <InputForm fluid type="number" name="pages" size="small" label="Páginas" />
                </Grid.Column>
                <Grid.Column mobile={16} tablet={8} computer={8}>
                  <InputForm
                    type="date"
                    fluid
                    name="publishDate"
                    size="small"
                    label="Data de publicação"
                  />
                </Grid.Column>
              </Grid.Row>
              {/*  */}
              <Grid.Row>
                <Grid.Column mobile={16} tablet={8} computer={8}>
                  <InputForm fluid name="description" size="small" label="Descrição" />
                </Grid.Column>
                <Grid.Column mobile={16} tablet={8} computer={8}>
                  <InputForm fluid name="synopsis" size="small" label="Sinopse" />
                </Grid.Column>
              </Grid.Row>
              {/*  */}
              <Grid.Row>
                <Grid.Column mobile={16} tablet={8} computer={8}>
                  <InputForm fluid name="imageUrl" size="small" label="Link da Imagem" />
                </Grid.Column>
                <Grid.Column mobile={16} tablet={8} computer={8}>
                  <InputForm fluid name="buyLink" size="small" label="Link de compra" />
                </Grid.Column>
              </Grid.Row>
              {/*  */}
              <Grid.Row>
                <Grid.Column mobile={16} tablet={16} computer={5}>
                  <b>Autor</b>
                  <br />
                  <DropdownAuthors
                    value={values.authorId}
                    onChange={authorId => formikState.setFieldValue('authorId', authorId)}
                  />
                  <br />
                  <CustomError name="authorId" />
                </Grid.Column>
                <Grid.Column mobile={16} tablet={16} computer={5}>
                  <b>Gênero</b> <br />
                  <DropdownGenres
                    value={values.genreId}
                    onChange={genreId => formikState.setFieldValue('genreId', genreId)}
                  />
                  <br />
                  <CustomError name="genreId" />
                </Grid.Column>
                <Grid.Column mobile={16} tablet={16} computer={5}>
                  <b>Editora</b>
                  <br />
                  <DropdownPublishingCompany
                    value={values.publishingCompanyId}
                    onChange={publishingCompanyId =>
                      formikState.setFieldValue('publishingCompanyId', publishingCompanyId)
                    }
                  />
                  <br />
                  <CustomError name="publishingCompanyId" />
                </Grid.Column>
              </Grid.Row>
              {/*  */}

              <Grid.Row centered>
                <Grid.Column>
                  <Button.Group floated="right">
                    <Button type="reset" color="red" size="big" onClick={() => onCancel()}>
                      <Icon name="cancel" />
                      Cancelar
                    </Button>
                    <Button type="submit" color="blue" size="big">
                      <Icon name="save" />
                      Salvar
                    </Button>
                  </Button.Group>
                </Grid.Column>
              </Grid.Row>
            </Grid>
          </Form>
        );
      }}
    />
  );
};

export default EditBook;
