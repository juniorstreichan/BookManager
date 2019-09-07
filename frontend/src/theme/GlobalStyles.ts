import { createGlobalStyle } from 'styled-components';

const GlobasStyles = createGlobalStyle`
  /* width */
  ::-webkit-scrollbar {
    width: 10px;
  }

  /* Track */
  ::-webkit-scrollbar-track {
    border-radius: 10px;
  }

  /* Handle */
  ::-webkit-scrollbar-thumb {
    background: #CACBCE;
    border-radius: 10px;

  }

  /* Handle on hover */
  ::-webkit-scrollbar-thumb:hover {
    background: #ddd;
  }
  body{
    background-image: linear-gradient(to top, #48c6ef 0%, #6f86d6 100%)!important; 
    background-repeat: no-repeat !important;
    background-attachment: fixed !important;
   }
`;

export default GlobasStyles;
