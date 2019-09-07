import React, { useContext } from 'react';
import { Dropdown } from 'semantic-ui-react';
import AppContext from '../../context/AppContext';

const DropdownPublishingCompany: React.FC<{
  onChange: (publishingCompanyId: number) => void;
  value?: number | null;
}> = ({ onChange, value }) => {
  const { state } = useContext(AppContext);
  return (
    <Dropdown
      fluid
      placeholder="Selecione uma Editora"
      options={state.publishingCompanies.map(a => ({
        key: a.id,
        value: a.id,
        text: a.name,
      }))}
      onChange={(e, { value }) => onChange((value as number) || 0)}
      selection
      search
      //@ts-ignore
      value={value || null}
    />
  );
};

export default DropdownPublishingCompany;
