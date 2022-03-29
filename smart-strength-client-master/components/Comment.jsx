import React, { useEffect, useState } from "react";

import { StyleSheet, View, Text, Image, AsyncStorage } from "react-native";
import moment from 'moment';
import { TouchableOpacity } from "react-native";
import { FontAwesome5 } from "@expo/vector-icons";
import commentsService from "../services/commentsService";

export default Comment = (props) => {
  let comment = props.comment;
  const [likes, setLikes] = useState(comment.likes);
  const [isLiked, setIsLiked] = useState(false);

  useEffect(() => {
    const init = async () => {
      const userId = await AsyncStorage.getItem("userId");
      if (comment.likes.indexOf(userId) >= 0) {
        setIsLiked(true);
      }
    }
    init();
  }, [])

  const likeComment = async () => {
    const userId = await AsyncStorage.getItem("userId");
    let oldLikes = JSON.parse(JSON.stringify(likes));
    setLikes([...likes, userId]);
    setIsLiked(true);
    const success = await commentsService.likeComment(comment.id, userId)
    if (!success) {
      setLikes(oldLikes);
      setIsLiked(false);
    }
  }

  const unlikeComment = async () => {
    const userId = await AsyncStorage.getItem("userId");
    let newLikes = JSON.parse(JSON.stringify(likes));
    newLikes = newLikes.filter(id => id != userId);
    setLikes(newLikes);
    setIsLiked(false);
    const success = await commentsService.unlikeComment(comment.id, userId)
    if (!success) {
      newLikes.push(userId);
      setLikes(newLikes);
      setIsLiked(true);
    }
  }

  return (
    <View style={{ flexDirection: "row" }}>
      <View style={styles.avatarContainer}>
        {(comment.author.avatar || props.defaultAvatar) && <Image
          resizeMode='contain'
          style={styles.avatar}
          source={{ uri: comment.author.avatar || props.defaultAvatar }}
        />}
      </View>
      <View style={styles.contentContainer}>
        <Text>
          <Text style={[styles.text, styles.name]}>{comment.author.name}</Text>
          {' '}
          <Text style={[styles.text, styles.created]}>
            {moment(comment.created).fromNow()}
          </Text>
        </Text>
        <Text style={styles.contentText}>{comment.content}</Text>
        <View style={{ flexDirection: "row", marginTop: 2 }}>
          <Text style={{ textAlignVertical: "center" }}>{likes.length} respects</Text>
          <TouchableOpacity
            style={styles.likeButton}
            onPress={() => {
              !isLiked ? likeComment() : unlikeComment()
            }}
          >
            <Text style={styles.button}>
              <FontAwesome5 size={18} name="dumbbell" color="white" /> {isLiked ? "Unrespect" : "Respect"}
            </Text>
          </TouchableOpacity>
        </View>
      </View>
    </View>

  )
}

const styles = StyleSheet.create({
  container: {
    flexDirection: 'row',
  },
  avatarContainer: {
    alignItems: 'center',
    marginLeft: 5,
    paddingTop: 10,
    width: 40,
  },
  contentContainer: {
    padding: 5,
    width: "100%"
  },
  avatar: {
    borderWidth: 1,
    borderColor: '#EEE',
    borderRadius: 13,
    width: 26,
    height: 26,
  },
  text: {
    color: '#000',
    fontFamily: 'OpenSans_400Regular',
    fontSize: 15,
  },
  contentText: {
    marginTop: 2,
    color: '#000',
    fontFamily: 'OpenSans_400Regular',
    fontSize: 18,
  },
  name: {
    fontWeight: 'bold',
  },
  created: {
    color: '#BBB',
  },
  likeButton: {
    backgroundColor: "#3b5998",
    paddingVertical: 5,
    borderRadius: 15,
    marginLeft: 10,
    width: "40%",
  },
  button: {
    fontSize: 13,
    color: "white",
    fontFamily: 'OpenSans_400Regular',
    textAlign: "center"
  },

})
