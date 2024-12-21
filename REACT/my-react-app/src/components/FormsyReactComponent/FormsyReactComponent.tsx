import React, { FC } from 'react';
import { FormsyReactComponentWrapper } from './FormsyReactComponent.styled';
import { Form, Field } from 'formsy-react';
interface FormsyReactComponentProps {}

const FormsyReactComponent: FC<FormsyReactComponentProps> = () => (
	<FormsyReactComponentWrapper data-testid="FormsyReactComponent">
		<div className="App">
			{' '}
			<h1>Contact Us</h1>{' '}
			<Form
				onSubmit={async (model) => {
					await new Promise((resolve) => setTimeout(resolve, 500));
					alert(JSON.stringify(model, null, 2));
				}}
			>
				{' '}
				<Field name="name" component="input" type="text" />{' '}
				<Field name="email" component="input" type="email" />{' '}
				<button type="submit">Submit</button>{' '}
			</Form>{' '}
		</div>
	</FormsyReactComponentWrapper>
);

export default FormsyReactComponent;
