import React, { FC } from 'react';
import { MyComponentWrapper } from './MyComponent.styled';
import styled from 'styled-components';
import { MyComponentProps } from './MyComponent.Props';
import './MyComponent.scss';

const MyComponent: FC<MyComponentProps> = ({ id }) => {
	return (
		<>
			<MyComponentWrapper className="app" data-testid="MyComponent">
				MyComponent Component
				<div>ppppp</div>
				<button>Click Me</button>
			</MyComponentWrapper>
		</>
	);
};

export default MyComponent;
