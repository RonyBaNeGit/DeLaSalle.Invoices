import React,{Fragment} from 'react';
import ReactDOM from 'react-dom';
import  App from './App';

var x = 1;
//const app = <Fragment> <div><h1>Hello World {x}</h1><h2>Hello World 2</h2></div></Fragment>;

ReactDOM.render(<App title="TitleText" text="text2" />, document.getElementById('root'));