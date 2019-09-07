import React from 'react';
import { Button, Card, Image, Popup, Label, Icon } from 'semantic-ui-react';
import Book from '../models/Book';

interface Props {
  book: Book;
  onClickEdit: Function;
  onCickDelete: Function;
}

const BookCard: React.FC<Props> = ({ book, onClickEdit, onCickDelete }) => {
  return (
    <Card>
      <Image fluid src={book.imageUrl} />
      {book.genre && <Label attached="top left">{book.genre.description}</Label>}
      <Card.Content extra textAlign="right">
        <Popup
          content={`Editar ${book.title}`}
          trigger={<Button icon="edit" circular onClick={() => onClickEdit()} />}
        />
        <Popup
          content={`Excluir ${book.title}`}
          trigger={<Button icon="trash" color="red" circular />}
        />
      </Card.Content>
      <Card.Content>
        <Card.Header>
          <Icon name="book" />
          {book.title}
        </Card.Header>
        {book.author && (
          <Card.Meta textAlign="right">
            <Icon name="user" />
            {book.author.name}
          </Card.Meta>
        )}

        <Card.Meta textAlign="right">
          Publicade em: {new Date(book.publishDate).toLocaleDateString()}
        </Card.Meta>
        <Card.Description>{book.description}</Card.Description>
      </Card.Content>
    </Card>
  );
};

export default BookCard;
