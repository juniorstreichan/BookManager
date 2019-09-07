import React, { useContext } from 'react';
import { Dropdown } from 'semantic-ui-react';
import AppContext from '../../context/AppContext';

const DropdownAuthors: React.FC<{
  onChange: (authorId: number) => void;
  value?: number;
}> = ({ onChange, value }) => {
  const { state } = useContext(AppContext);
  return (
    <Dropdown
      fluid
      placeholder="Selecione um Autor"
      options={state.authors.map(a => ({ key: a.id, value: a.id, text: a.name }))}
      onChange={(e, { value }) => onChange((value as number) || 0)}
      selection
      search
      //@ts-ignore
      value={value || null}
    />
  );
};

export default DropdownAuthors;
