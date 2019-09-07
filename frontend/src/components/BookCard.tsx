import React from 'react';
import { Button, Card, Image } from 'semantic-ui-react';
import Book from '../models/Book';

interface Props {
  book: Book;
  onClickEdit: Function;
  onCickDelete: Function;
}

const BookCard: React.FC<Props> = ({ book, onClickEdit, onCickDelete }) => {
  return (
    <Card>
      <Image src={book.imageUrl} />
      <Card.Content extra textAlign="right">
        <Button icon="edit" circular />
        <Button icon="trash" color="red" circular />
      </Card.Content>
      <Card.Content>
        <Card.Header>{book.title}</Card.Header>
        <Card.Meta>Publicade em: {new Date(book.publishDate).toLocaleDateString()}</Card.Meta>
        <Card.Description>{book.description}</Card.Description>
      </Card.Content>
    </Card>
  );
};

export default BookCard;
