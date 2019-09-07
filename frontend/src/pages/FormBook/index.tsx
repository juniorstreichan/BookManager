import React, { Fragment, useState } from 'react';
import { RouteComponentProps } from 'react-router';
import { Message, Segment } from 'semantic-ui-react';
import axios from 'axios';
import Book from '../../models/Book';
import NewBook from './NewBook';
import { NewBookForm } from './schemas';
import EditBook from './EditBook';

const FormBook: React.FC<RouteComponentProps> = ({ location, history }) => {
  const { state } = location;
  const [isLoadding, setIsLoadding] = useState<boolean>(false);
  const onSubmit = (book: Book | NewBookForm) => {
    (async () => {
      try {
        setIsLoadding(true);
        const method = !state ? 'post' : 'put';
        const response = await axios[method](`${process.env.REACT_APP_API_URL}/api/books`, book);
        console.log(response);

        if (response.status === 201 || response.status === 200) {
          history.push('/');
        }
      } catch (e) {
      } finally {
        setIsLoadding(false);
      }
    })();
  };

  const onCancel = () => {
    history.push('/');
  };
  return (
    <Fragment>
      <Segment loading={isLoadding} compact>
        <Message color="green" compact attached="top">
          {!state ? <strong> Adicionando novo Livro</strong> : <strong> Edição de Livro</strong>}
        </Message>
        {state ? (
          <EditBook onSubmit={onSubmit} onCancel={onCancel} book={state.book} />
        ) : (
          <NewBook onSubmit={onSubmit} onCancel={onCancel} />
        )}
      </Segment>
    </Fragment>
  );
};

export default FormBook;
