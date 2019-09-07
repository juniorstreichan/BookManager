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
    background-image: linear-gradient(to top, #00c6fb 0%, #0D71BB 100%)!important; 
    background-repeat: no-repeat !important;
    background-attachment: fixed !important;
   }
`;

export default GlobasStyles;
