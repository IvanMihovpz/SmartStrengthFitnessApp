import React, { useState } from "react";
import { KeyboardAvoidingView, TouchableOpacity, View, TextInput, StyleSheet, Text } from "react-native";

export default CommentInput = (props) => {
  const onChangeText = (text) => {
    props.setCommentText(text)
  };

  const submit = (text) => {
    if (text) {
      props.setCommentText("");
      props.submitComment(text);
    } else {
      alert('Please enter your comment first');
    }
  };

  const onSubmitEditing = ({ nativeEvent: { text } }) => {
    props.setCommentText(text);
    submit(text);
  };

  return (
    // This moves children view with input field and submit button
    // up above the keyboard when it's active
    <KeyboardAvoidingView
      behavior='position'
    >
      <View style={styles.container}>
        {/* Comment input field */}
        <TextInput
          placeholder="Add a comment..."
          keyboardType="twitter" // keyboard with no return button
          autoFocus={false} // focus and show the keyboard
          style={styles.input}
          value={props.commentText}
          onChangeText={onChangeText} // handle input changes
          onSubmitEditing={onSubmitEditing} // handle submit event
        />
        {/* Post button */}
        <TouchableOpacity
          style={styles.button}
          onPress={submit}
        >
          {/* Apply inactive style if no input */}
          <Text style={[styles.text, !props.commentText ? styles.inactive : []]}>Post</Text>
        </TouchableOpacity>
      </View>
    </KeyboardAvoidingView>
  );
}

const styles = StyleSheet.create({
  container: {
    backgroundColor: '#FFF',
    flexDirection: 'row',
    borderTopWidth: 1,
    borderColor: '#EEE',
    alignItems: 'center',
    paddingLeft: 15,
    marginTop: 5
  },
  input: {
    flex: 1,
    height: 40,
    fontSize: 15,
  },
  button: {
    height: 40,
    paddingHorizontal: 20,
    alignItems: 'center',
    justifyContent: 'center',
  },
  inactive: {
    color: '#CCC',
  },
  text: {
    color: '#3F51B5',
    fontWeight: 'bold',
    fontFamily: 'OpenSans_400Regular',
    textAlign: 'center',
    fontSize: 15,
  },
});
